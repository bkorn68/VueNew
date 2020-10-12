<template>
    <div>
    <h2>Touren:</h2>
    <ul>
    <li v-bind:key="tour.orderId" v-for="tour in tourList">
        <TourItem v-bind:tour="tour" />
    </li>
    </ul>

    </div>
</template>

<script>
    import TourItem from "./TourItem";
    export default {
        name: 'TourList',
        components: {
            TourItem
        },
        props: [
            'tourList'
        ]
    }
</script>

<style lang="scss" scoped>

</style>