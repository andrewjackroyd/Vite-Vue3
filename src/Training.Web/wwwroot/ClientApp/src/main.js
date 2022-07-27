import { createApp, h, provide } from 'vue';
import { ApolloClient, createHttpLink, InMemoryCache, } from '@apollo/client/core';
import { DefaultApolloClient } from '@vue/apollo-composable';
import App from './App.vue';
const httpLink = createHttpLink({
    uri: 'http://localhost:3000/graphql',
});
const cache = new InMemoryCache();
const defaultApolloClient = new ApolloClient({
    link: httpLink,
    cache,
});
const app = createApp({
    setup() {
        provide(DefaultApolloClient, defaultApolloClient);
    },
    render: () => h(App),
});
app.mount('#app');
//# sourceMappingURL=main.js.map