import { defineConfig, loadEnv } from 'vite'
import react from '@vitejs/plugin-react-swc'
import tailwindcss from '@tailwindcss/vite'

export default defineConfig(({ mode }) => {
  // Load env variables for the current mode (e.g., development, production)
  const env = loadEnv(mode, process.cwd());

  console.log("Using API base URL:", env.VITE_API_BASE_URL); // for debug

  return {
    plugins: [tailwindcss(), react()],
    server: {
      host: true,
      watch: {
         usePolling: true,
      },
    }
  };
});