
import axios from 'axios';

const url = 'http://localhost:56452/api/';
const loginUrl = url + 'Login/';


export default {
  login(credentials) {
    return axios
      .post(loginUrl, credentials)
      .then(response => response.data);
  }
}