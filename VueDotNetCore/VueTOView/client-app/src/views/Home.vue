// src/views/Home.vue

<template>
  <div>
  <h2>Home</h2>
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