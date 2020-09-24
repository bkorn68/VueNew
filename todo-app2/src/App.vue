<template>
  <div id="app">

   <Todos v-bind:todos="todos"/>
  </div>
</template>


<script>
import Todos from "./components/Todos"
export default {
  name: 'App',
  components: {
    Todos
  },
  data() {
    return {
 todos: [

      {
        title: "Medikamente kaufen",
        erledigt: false
      },
      {
        title: "Vue-Dokumentation lesen",
        erledigt: false
      },
      {
        title: "Film schauen",
        erledigt: false
      },
      {
        title: "Anja anrufen",
        erledigt: false
      },
      {
        title: "Ines anrufen",
        erledigt: false
      }
    ]    }
   
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
