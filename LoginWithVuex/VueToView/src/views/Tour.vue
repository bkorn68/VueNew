<template>
  <div>
    <h2>Login</h2>
    <div class="container">
    <label for="uname"><b>Monteur</b></label>
    <select v-model="selectedTechnichian">
    <option v-bind:value="{name: technichian.name,sourceId: technichian.sourceId}" v-for="technichian in technichians">
      {{technichian.name + '[' + technichian.sourceId + ']' }}
      </option>

</select>


    <label for="psw"><b>Tag</b></label>
    <input type="date" v-model="selectedDate" />


    <button type="submit" @click="getTours">Touren</button>
    <p v-if="msg">{{ msg }}</p>
    <TourList v-bind:tourList="tourList" v-if="this.toursfound" />
    <button type="submit" @click="showGoogle" v-if="this.toursfound" >Google</button>
    
    
  </div>
  
    
  </div>
</template>

<script>
import TOService from '@/services/TOService.js';
import TourList from "../components/TourList"

    export default {
    data() {
    return {
      technichians: [
      ],
      //10925
      selectedTechnichian: {
          },
      
      selectedDate: '2020-10-01',
      environment: 1,
      msg: 'Lade Monteure...',
      tourList: [],
      toursfound: false,
      googleURL: ''
      
    }
  },
  components: {
    TourList
  },
  methods: {
      async getTours()
        {
        try
        {
         this.toursfound = false;
         console.log("Start getTours")
         this.msg = 'ermittel Touren';
         const date = new Date(this.selectedDate);
         const jsonDate = date.toJSON();

      const request = {
           ident: this.$store.getters.getIdent,
           mandatorId: this.$store.getters.getMandatorId,
           technicianID: {
"IdentificationId":2,
      "DataSourceId":2,
      "DataTypeId":1016,
      "SourceId": this.selectedTechnichian.sourceId,
      "MandatorId": this.$store.getters.getMandatorId
           },
           date: jsonDate,
           environment: this.environment
         };
         console.log("Request:");
         console.log(request);
         const response = await TOService.getTours(request);
                  const tours = response;
         let count = tours.length;
         if (count > 0)
         {
         this.tourList = tours;
         this.msg = count + ' Touren gefunden';
         this.toursfound = true;
         }

        }
     catch(error)
    {
      console.log(error);
        this.msg = 'Abruf Touren fehlgeschlagen';
    }
     

      },
      showGoogle()
      {
        
        this.googleURL = 'https://www.google.de/maps/dir';
        this.tourList.forEach(tour => 
        {
          this.googleURL = this.googleURL + '/' + tour.geoLatitude + ',' + tour.geoLongitude;
        }
        
        );
        console.log('GoogleUrl:');
        console.log(this.googleURL);
        window.location.href = this.googleURL;
        
      }
  },
  async created() {
    
    try
    {
      console.log("Start getTechnicians")

      const request = {
           ident: this.$store.getters.getIdent,
           mandatorId: this.$store.getters.getMandatorId,
           environment: this.environment
         };
         console.log("Request:");
         console.log(request);
         
         const response = await TOService.getTechnicians(request);
         const techs = response;
         let count = techs.length;
         this.technichians = techs;
         this.msg = count + ' Monteuere gefunden';

         
    }
    catch(error)
    {
      console.log(error);
        this.msg = 'Abruf Monteuere fehlgeschlagen';
    }
    
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