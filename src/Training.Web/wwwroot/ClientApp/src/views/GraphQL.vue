<template>
  <div>
    <h4>GraphQL Example</h4>
    <span>featuring...</span>
    <p></p>
    <a href="" @click.prevent="abc('https://graphql.org/')">graphql.org</a> |
    <a
      href=""
      @click.prevent="
        abc(
          'https://chillicream.com/docs/hotchocolate/defining-a-schema/queries'
        )
      "
      >chillicream.com</a
    >
    |
    <a
      href=""
      @click.prevent="
        abc('https://v4.apollo.vuejs.org/guide-composable/query.html')
      "
      >apollo</a
    >

    <p></p>
    <div><button @click="onFetchButtonClick">Fetch Data</button></div>

    <span>{{ customer }}</span>
    <p></p>
    <div><button @click="onGraphButtonClick">Fetch Graph Data</button></div>
    <span>{{ graphCustomer }}</span>
  </div>
</template>

<script setup>
import { ref, computed } from 'vue';
import { useQuery } from '@vue/apollo-composable';
import gql from 'graphql-tag';

let customer = ref();
const enabled = ref(false);

function abc(url) {
  window.open(url);
}

async function onFetchButtonClick() {
  const response = await fetch('http://localhost:3000/api/customer/1', {
    method: 'GET',
    mode: 'no-cors',
    cache: 'no-cache',
    headers: { 'Content-type': 'application/json' },
  });
  const json = await response.json();
  customer.value = json;
}

const CUSTOMER_QUERY = gql`
  query getCustomerById($id: Int!) {
    customer(id: $id) {
      id
      name
    }
  }
`;

const variables = ref({
  id: 1,
});

const { result, refetch } = useQuery(CUSTOMER_QUERY, variables, () => ({
  enabled: enabled.value,
}));

function selectCustomer(id) {
  variables.value = {
    id,
  };
}

selectCustomer(5);

const graphCustomer = computed(() => result.value);

async function onGraphButtonClick() {
  enabled.value = true;
  refetch();
}
</script>
