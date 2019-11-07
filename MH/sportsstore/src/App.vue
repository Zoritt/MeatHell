<template>
    <router-view />
</template>
<script>
  import { mapActions } from "vuex";
  export default {
      name: 'app',
      methods: {
          ...mapActions({
            getData: "getData",
         }) 
      },
      created() {
          this.getData();
      }
 }
</script>

