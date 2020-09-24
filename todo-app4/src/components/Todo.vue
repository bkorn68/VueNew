<template>
    <div>
    <p>{{todo.title}}</p>
    </div>
</template>

<script>
    export default {
        name: 'ToDo',
        props: [
            'todo'
        ]
    }
</script>

<style lang="scss" scoped>

</style>