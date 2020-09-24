<template>
  <div>
    <h2>Meine Aufgabeliste</h2>
    <ul>
      <li v-bind:key="todo.id" v-for="todo in todos">
        <Todo v-bind:todo="todo" />
      </li>
    </ul>
  </div>
</template>
<script>
import Todo from "./Todo";
export default {
    name: "Todos",
    components: {
        Todo
    },
    props: [
        "todos"
    ]

}
</script>