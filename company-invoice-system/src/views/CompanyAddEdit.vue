<style scoped>

.addmargin {
    margin-top: 10px;
    margin-bottom: 10px;
}

.vue-logo-back {
    background-color: black;
}
  

</style>

<template>

<div class="home">
     <div class="card" v-if="companyDetails.id">
        <div class="card-header">
            Add/Edit Company Details
        </div>

        <form id="add-edit-form" @submit.prevent="processForm">
            <div class="card-body">
                <div class="field">
                    <label class="label mr-2">Company Name</label>
                    <input 
                        type="text"
                        class="input" 
                        name="name"
                        v-model="companyDetails.name">
                </div>

                <div class="field">
                    <label class="label mr-2">Company Name</label>
                    <input 
                        type="text"
                        class="input" 
                        name="name"
                        v-model="companyDetails.name">
                </div>

                <h2 class="card-title">{{companyDetails.name}}</h2>
                <!-- <p class="card-text">Company Name : {{companyDetails.name}}</p> -->
                <p class="card-text">EIN : {{companyDetails.ein}}</p>
                <p class="card-text">{{companyDetails.addressStreet !== null ? companyDetails.addressStreet  + ' ' + companyDetails.addressUnitNumber : null}}</p>
                <p class="card-text">{{companyDetails.city != null ? companyDetails.city + ', ' + companyDetails.state + ' ' + companyDetails.zipCode : null }}</p>
                <p class="card-text">{{companyDetails.phoneNumber}}</p>
            
                <a v-on:click="goToMainPage()" class="btn btn-primary"><span style="color:white">Go Back</span></a>
            </div>
        </form>
    </div>


</div>

</template>

<script>
// @ is an alias to /src
import axios from 'axios'
import moment from 'moment'

export default {
    name: 'companydetails',
    mounted() 
    {
        axios({
            method: "GET",
            "url": "https://localhost:44389/api/company/getcompany?id="+this.$route.params.id
        }).then(response => {
            this.companyDetails = response.data;
        }, error => {
            console.error(error);
        }); 
        
        axios({
            method: "GET",
            "url": "https://localhost:44389/api/invoice/getinvoices?companyid="+this.$route.params.id
        }).then(response => {
            this.companyInvoices = response.data;
        }, error => {
            console.error(error);
        }); 
    },
    data() { 
        return {
            companyDetails: {},   
            companyInvoices: {},                 
        }
    },
    methods: {
        goToMainPage: function() {
            this.$router.push("/companies");
        },
        moment
    }
}


</script>
