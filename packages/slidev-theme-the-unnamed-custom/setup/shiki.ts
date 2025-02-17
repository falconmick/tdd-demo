/* ./setup/shiki.ts */
import { defineShikiSetup } from "@slidev/types";
import darkTheme from '../public/theme/theunnamed-dark-theme.json'

export default defineShikiSetup(() => {
  return {
    themes: {
      dark: darkTheme as any,
      light: 'github-light-high-contrast',
    },
  };
});
