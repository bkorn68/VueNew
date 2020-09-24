<template>
  <div id="app">
    <Todos v-bind:todos="todos" />
    
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
          id: 1,
          title: 'Aufgabe 1',
          erledigt: false
        },
        {
          id: 2,
          title: 'Aufgabe 2',
          erledigt: false
        },
        {
          id: 3,
          title: 'Aufgabe 3',
          erledigt: false
        },
        {
          id: 4,
          title: 'Aufgabe 4',
          erledigt: false
        }
      ]
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
