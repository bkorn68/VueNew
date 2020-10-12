<template>
    <div id="app" class="newapp">
        <img alt="Vue logo" id="newlogo" src="./assets/dotnetcore-vue.jpg">
        <input type="hidden" id="hintidentifier" value="dotnetcore" />
        <HelloWorld msg="Hallo Bernhard und Claudia" />
        <div v-bind:key="r" v-for="r in this.values">{{ r }}</div>
    </div>
</template>

<script>
import HelloWorld from './components/HelloWorld.vue'

export default {
  name: 'app',
  components: {
    HelloWorld
        },
  data() {
      return {
          values: ['Bernhard', 'Korn']
 
    };
        },
   async created() {
    const r = await fetch('/api/values');
    this.values = await r.json();
  }
}
</script>

<style>
    .newapp{
        text-align:center;
        margin-top:50px;    
    }
</style>
