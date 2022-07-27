<template>
  <div>
    <div><button @click="onFetchButtonClick">Fetch Data</button></div>
    <span>{{ customer }}</span>
    <div><button @click="onGraphButtonClick">Fetch Graph Data</button></div>
    <span>{{ graphCustomer }}</span>
  </div>
</template>

<script setup>
import { ref, computed } from 'vue';
import { useQuery } from '@vue/apollo-composable';
import gql from 'graphql-tag';

let customer = ref({});
const enabled = ref(false);

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
  {
    customer {
      id
      name
    }
  }
`;
const { result, loading, error, refetch } = useQuery(
  CUSTOMER_QUERY,
  null,
  () => ({
    enabled: enabled.value,
  })
);

const graphCustomer = computed(() => result.value);

async function onGraphButtonClick() {
  enabled.value = true;
  refetch();
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}

.list-wrapper {
  display: flex;
  margin: 0 auto;
  max-width: 960px;
}

.list {
  width: 50%;
}
</style>
