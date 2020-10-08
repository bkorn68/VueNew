<template>
    <div>
        <h2>Tour</h2>
        <div>
            <label>Monteur</label>
        <select v-model="selectedSourceID">
  <option v-for="technichian in technichians" v-bind:value="technichian.SourceID">
    `${technichian.Name},[${technichian.SourceID}]`
  </option>
</select>
<span>SelectedSourceID: {{ selectedSourceID }}</span>     
</div>
<div>
    <label>Tag</label>
    <input type="date" v-model="selectedDate" />
    <span>selectedDate: {{ selectedDate }}</span>

</div>
<input type="button" @click="getTours" value="getTours" />







    </div>
</template>

<script>
    export default {
    data() {
    return {
      technichians: [
          {
              "Name": "Bernhard Korn",
              "SourceID": 12345
          },
          {
              "Name": "Hendrik Kokulinsky",
              "SourceID": 23456
          },
          {
              "Name": "Wolfgang Lorenz",
              "SourceID": 34567
          }
      ],
      selectedSourceID: '12345',
      selectedDate: '2017-07-04'
      
    }
  },
  methods: {
      getTours()
      {
          console.log("getTours is not yet implemented");
      }
  }
    }
</script>

<style lang="scss" scoped>

</style>