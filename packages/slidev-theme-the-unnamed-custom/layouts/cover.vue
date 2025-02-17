<script setup lang="ts">
import { computed } from 'vue'
import { handleBackground } from '../utils/layoutHelper'
const props = defineProps({
  background: {
    default: '',
  },
  dimBackground: {
    default: true
  }
})

const slideBg = handleBackground(props.background, props.dimBackground);
const style = computed(() => slideBg)
const dimBackgroundClass = computed(() => props.dimBackground ? 'fade-background' : '');
</script>

<template>
  <div class="slidev-layout cover" :style="style" v-bind:class="(slideBg.background || slideBg.backgroundImage) ? dimBackgroundClass : 'no-background'">
    <div class="my-auto w-full">
      <slot />
    </div>
  </div>
</template>