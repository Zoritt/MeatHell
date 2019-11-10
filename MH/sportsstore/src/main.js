import Vue from 'vue'
import App from './App.vue'
Vue.config.productionTip = false
import "bootstrap/dist/css/bootstrap.min.css";
import "font-awesome/css/font-awesome.min.css"
import store from "./store"; 
import router from "./router"; 
import Vuelidate from "vuelidate";
Vue.filter("currency", (value) =>  new Intl.NumberFormat("pl-PL",
      { style: "currency", currency: "PLN" }).format(value));
Vue.use(Vuelidate);
new Vue({
  render: h => h(App),
  store,
  router
}).$mount('#app')

