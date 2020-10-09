
import axios from 'axios';

const url = 'http://localhost:56452/api/';
//{{local_url}}/api/Technicians
const techniciansUrl = url + 'Technicians';


export default {
    getTechnicians(request) {
    return axios
      .post(techniciansUrl, request)
      .then(response => response.data);
  },
  logTechniciansUrl()
  {
      console.log("TechniciansUrl:" + techniciansUrl);
  }
}