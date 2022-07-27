import { defineConfig } from 'vite'
import vue from '@vitejs/plugin-vue'
import * as path from 'path';

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
        target: 'https://localhost:7208/graphql',
        changeOrigin: true,
        secure: false,
        rewrite: (path) => path.replace(/^\/graphql/, '')
      }
    }
  },
  resolve: {
    alias: {
      '@/': `${path.resolve(__dirname, 'src')}/`
    }
  },
  plugins: [vue()]
})
