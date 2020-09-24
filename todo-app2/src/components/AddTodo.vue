<template>
    <div>
    <form @submit="addTodo">
    <input type="text" v-model="title" name="title">
    <button type="submit">Add</button>

    </form>>

    </div>
</template>

<script>
    export default {
        name: 'AddTodo',
        data() {
            return {
                title: '',
            }
        },
        methods: {
            addTodo(e) {
                e.preventDefault();
                const newTodoObj = {
                    id: 9,
                    title: this.title,
                    
                    erledigt: false,
                }
                this.$emit('add-todo', newTodoObj);
                this.title = '';

            }
        }
    }
</script>

<style lang="scss" scoped>

</style>