// src/views/Home.vue

<template>
  <div>
  </div>
</template>

<script>

export default {
  async created() {
    if (!this.$store.getters.isLoggedIn) {
      this.$router.push('/login');
    }

  },
};
</script>