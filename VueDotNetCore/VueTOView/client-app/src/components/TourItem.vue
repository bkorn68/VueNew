<template>
    <div>
    <p>{{tour.orderId + ' ' + tour.realStart + ' - ' + tour.realEnd + ' ' + tour.geoLatitude + ' ' + tour.geoLongitude + ' ' + tour.address }}</p>
    </div>
</template>

<script>
    export default {
        name: 'TourItem',
        props: [
            'tour'
        ]
    }
</script>

<style scoped>

</style>