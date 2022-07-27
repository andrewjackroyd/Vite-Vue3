import { defineConfig } from 'vite'
import vue from '@vitejs/plugin-vue'

// https://vitejs.dev/config/
export default defineConfig({
  server: {
    proxy: {
      '/api': {
        target: 'https://localhost:7208/api',
        changeOrigin: true,
        secure: false,
        rewrite: (path) => path.replace(/^\/api/, '')
      },
      '/graphql': {
        target: 'https://localhost:7208/graphql', changeOrigin: true,
        rewrite: (path) => path.replace(/^\/graphql/, '')
      }
    }
  },
  plugins: [vue()]
})
