
<template>
  <div>
    <h2>Login</h2>
    <div>
      <label>Benutzername</label>
      <input type="text" placeholder="Username" v-model="loginname" />
    </div>
    <div>
      <label>Kennwort</label>
      <input type="text" placeholder="Password" v-model="password" />
    </div>   
    <input type="button" @click="login" value="Login" />
    <p v-if="msg">{{ msg }}</p>
  </div>
</template>
<script>
import AuthService from '@/services/AuthService.js';

export default {
  data() {
    return {
      pwtoken: '',
      loginname: '',
      password: '',
      environment: 1,
      msg: ''
    };
  },
  methods: {
    async login() {
      try {
        const credentials = {
          pwtoken: this.pwtoken,
          loginname: this.loginname,
          password: this.password,
          environment: this.environment
        };
        const response = await AuthService.login(credentials);
       
        


        const ident = response;
        console.log('Ident');
        console.log(ident);
        const token = response.token;
        console.log('token');
        console.log(token);
              const mandatorId = response.mandatorIds[0];

              // const mandatorId = 1;
              console.log('mandatorId');
        console.log(mandatorId);

        this.$store.dispatch('login', {ident, token, mandatorId });

        this.$router.push('/tour');
      } catch (error) {
        console.log(error);
        this.msg = 'Login fehlgeschlagen';
      }
    }
  }
};
</script>