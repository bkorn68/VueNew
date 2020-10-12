<template>
  <div id="app">
    <img alt="Vue logo" src="./assets/logo.png">
    <HelloWorld msg="Welcome to Your Vue.js App"/>
  </div>
</template>

<script>
import HelloWorld from './components/HelloWorld.vue'

export default {
  name: 'App',
  components: {
    HelloWorld
  },
  created()
  {
    try
    {
      const credentials = {
          pwtoken: 'CA8D4F9987F3A71EEEA140122D33F762',
          loginname: 'b.korn',
          password: 'kb0701#AIB',
          passwordhash: '66bfde2c10cd7277bce707362d4fd379',
          environment: 1
        };
        this.Loading = true;
        const response = await AuthService.login(credentials);
    }
    catch (error) {
        console.log(error);

      }
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
  margin-top: 60px;
}
</style>
