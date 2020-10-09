import Vue from 'vue'
import { VueSpinners } from '@saeris/vue-spinners'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'
import Login from '../views/Login.vue'

import Tour from '../views/Tour.vue'


Vue.use(VueRouter)
Vue.use(VueSpinners)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: "/login",
    name: "login",
    component: Login
  },
  
  {
    path: "/tour",
    name: "tour",
    component: Tour
  }
]

const router = new VueRouter({
  routes
})

export default router
