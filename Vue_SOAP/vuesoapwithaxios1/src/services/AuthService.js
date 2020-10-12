import axios from 'axios';

const url = 'http://localhost:56452/api/';
const loginUrl = url + 'Login/';


export default {
  login(credentials) {
    const pwtoken = credentials.pwtoken;
    const loginname = credentials.loginname;
    const password = credentials.password;
    const passwordhash = credentials.passwordhash;
    const environment = credentials.environment;

    return axios
      .post(loginUrl, credentials)
      .then(response => response.data);
  }
}