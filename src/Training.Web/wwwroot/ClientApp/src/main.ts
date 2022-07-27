import { createApp, h, provide } from 'vue';
import {
    ApolloClient,
    createHttpLink,
    InMemoryCache,
} from '@apollo/client/core';
import { DefaultApolloClient } from '@vue/apollo-composable';
import { createRouter, createWebHistory } from 'vue-router';
import Home from '@/views/Home.vue';
import GraphQl from '@/views/GraphQL.vue';

import App from './App.vue';

const httpLink = createHttpLink({
    uri: 'http://localhost:3000/graphql',
})
const cache = new InMemoryCache();

const defaultApolloClient = new ApolloClient({
    link: httpLink,
    cache,
});

const router = createRouter({ history: createWebHistory(), routes: [{ path: '/', component: Home }, { path: '/graphql', component: GraphQl }] })

const app = createApp({
    setup() {
        provide(DefaultApolloClient, defaultApolloClient);
    },
    render: () => h(App),
}).use(router);

app.mount('#app');
