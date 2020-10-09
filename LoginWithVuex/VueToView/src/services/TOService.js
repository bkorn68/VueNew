
import axios from 'axios';

const url = 'http://localhost:56452/api/';

// const techniciansUrl = url + 'Technicians';
const techniciansUrl = 'https://bodega-live.servicebus.windows.net/bodegaGemasMasterdata/rest/GetTechnicians'

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