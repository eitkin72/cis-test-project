<template>
  <div class="col-md-5 centeralign">
    <b-alert show> 
      <div v-for="detail in selectedCompany" :key="detail">
          <div>{{detail}}</div>
      </div>       
    </b-alert>   
  </div>
</template>

<script>
export default {
  name: 'display',
  props: {
    selectedCompany: {}
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
