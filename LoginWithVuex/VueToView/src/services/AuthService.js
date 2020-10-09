
import axios from 'axios';

const url = 'http://localhost:56452/api/';
const loginUrl = url + 'Login/';
// const loginUrl = 'https://bodega-live.servicebus.windows.net/bodegaAuthorizer/rest/Login';


export default {
  login(credentials) {
    return axios
      .post(loginUrl, credentials)
      .then(response => response.data);
  }
}