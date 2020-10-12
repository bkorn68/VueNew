<template>
  <div id="app">
    <div id="nav">
      <router-link to="/">Home</router-link> 
      <router-link v-show="isLoggedIn" to="/tour"> | Tour</router-link> 
      <router-link v-show="!isLoggedIn" to="/login"> | Login</router-link> 
      <span v-if="isLoggedIn"> | <a class="clickable" @click="logout">Logout</a></span>
    </div>
    <h1>TOView</h1>
    <img alt="Vue logo" src="./assets/buologo.jpg">
    <router-view/>
  </div>
</template>
<script>
  export default {
    computed : {
      isLoggedIn : function(){ return this.$store.getters.isLoggedIn}
    },
    methods: {
      logout: function () {
        this.$store.dispatch('logout')
        .then(() => {
          this.$router.push('/login')
        })
      }
    },
    created()
    {
      this.$store.dispatch('resetstore');
    }
    
  }
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

#nav {
  padding: 30px;
}

#nav a {
  font-weight: bold;
  color: #2c3e50;
}

#nav a.router-link-exact-active {
  color: #42b983;
}
a.clickable{
       cursor: pointer;
       cursor: hand;
   }
</style>
