<template>
  <div>
    <!-- <p v-for="book in result.allBooks" :key="book.id">
      {{ book.title }}
    </p> -->
  </div>
</template>

<script lang="ts">
import { useQuery } from '@vue/apollo-composable';
import gql from 'graphql-tag';

const CUSTOMER_QUERY = gql`
  {
    customer {
      id
      name
    }
  }
`;

const getData = () => {
  fetch('https://localhost:7208/api/customer/1', {
    method: 'GET',
    mode: 'no-cors',
    cache: 'no-cache',
    headers: { 'Content-type': 'application/json' },
  }).then((res) => console.log(res));
};

export default {
  name: 'App',
  setup() {
    const test = getData();
    console.log(test);

    // const { result } = useQuery(CUSTOMER_QUERY);

    // console.log(result);

    // return { result };
  },
};
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
