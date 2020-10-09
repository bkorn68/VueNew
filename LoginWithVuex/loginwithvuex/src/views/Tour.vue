<template>
  <div>
    <h2>Login</h2>
    <div class="container">
    <label for="uname"><b>Monteur</b></label>
    <select v-model="selectedSourceID">
  <option v-for="technichian in technichians" v-bind:value="technichian.SourceID">
    {{technichian.Name + '[' + technichian.SourceID + ']' }}
  </option>
</select>

    <label for="psw"><b>Tag</b></label>
    <input type="date" v-model="selectedDate" />


    <button type="submit" @click="getTours">Touren</button>
    
  </div>
    
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
  },
  created: function () {
    this.selectedDate = new Date().format('YYYY-MM-DD');
  }
    }
</script>

<style scoped>
body {font-family: Arial, Helvetica, sans-serif;}
form {border: 3px solid #f1f1f1;}
/* Bordered form */
form {
  border: 3px solid #f1f1f1;
}
/* Full-width inputs */
input[type=text], input[type=date] {
  width: 100%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  box-sizing: border-box;
}
/* Full-width select */
select {
width: 100%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  box-sizing: border-box;

}
/* Set a style for all buttons */
button {
  background-color: #031c3d;
  color: white;
  padding: 14px 20px;
  margin: 8px 0;
  border: none;
  cursor: pointer;
  width: 100%;
}
/* Add a hover effect for buttons */
button:hover {
  opacity: 0.8;
}
/* Add padding to containers */
.container {

padding-left: 560px;
  padding-right: 560px;
vertical-align: middle;
  
}
</style>