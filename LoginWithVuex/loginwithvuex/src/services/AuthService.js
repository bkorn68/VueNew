// src/services/AuthService.js

import axios from 'axios';

const url = 'http://localhost:56452/api/';

export default {
  login(credentials) {
    return axios
      .post(url + 'Login/', credentials)
      .then(response => response.data);
  }
}