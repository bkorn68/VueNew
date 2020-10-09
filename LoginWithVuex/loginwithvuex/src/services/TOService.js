
import axios from 'axios';

const url = 'http://localhost:56452/api/';
//{{local_url}}/api/Technicians
const techniciansUrl = url + 'Technicians';
//{{local_url}}/api/Tours
const toursUrl = url + 'Tours';

export default {
    getTechnicians(request) {
    return axios
      .post(techniciansUrl, request)
      .then(response => response.data);
  },
  getTours(request) {
    return axios
      .post(toursUrl, request)
      .then(response => response.data);
  }

}