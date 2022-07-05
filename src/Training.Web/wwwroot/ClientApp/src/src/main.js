import { createApp, h, provide } from 'vue';
import { ApolloClient, createHttpLink, InMemoryCache, } from '@apollo/client/core';
import { DefaultApolloClient } from '@vue/apollo-composable';
import App from './App.vue';
const httpLink = createHttpLink({
    uri: 'https://localhost:7208//graphql',
});
const cache = new InMemoryCache();
const apolloClient = new ApolloClient({
    link: httpLink,
    cache,
});
const app = createApp({
    setup() {
        provide(DefaultApolloClient, apolloClient);
    },
    render: () => h(App),
});
app.mount('#app');
//# sourceMappingURL=main.js.map