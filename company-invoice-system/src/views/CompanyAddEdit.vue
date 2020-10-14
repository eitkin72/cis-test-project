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
                <h2 class="card-title">{{companyDetails.name}}</h2>

                <div class="field">
                    <label class="label mr-2">Company Name</label>
                    <input 
                        type="text"
                        class="input" 
                        name="name"
                        v-model="companyDetails.name">
                </div>

                <div class="field">
                    <label class="label mr-2">EIN Number</label>
                    <input 
                        type="number"
                        class="input" 
                        name="ein"
                        v-model="companyDetails.ein">
                </div>

                <div class="field">
                    <label class="label mr-2">Street Address</label>
                    <input 
                        type="text"
                        class="input" 
                        name="addressStreet"
                        v-model="companyDetails.addressStreet">
                </div>

                <div class="field">
                    <label class="label mr-2">Unit Number</label>
                    <input 
                        type="text"
                        class="input" 
                        name="addressUnitNumber"
                        v-model="companyDetails.addressUnitNumber">                    
                </div>

                 <div class="field">
                    <label class="label mr-2">City</label>
                    <input 
                        type="text"
                        class="input" 
                        name="city"
                        v-model="companyDetails.city">                    
                </div>

                <div class="field">
                    <label class="label mr-2">State</label>
                    <input 
                        type="text"
                        class="input" 
                        name="state"
                        v-model="companyDetails.state">                    
                </div>

                <div class="field">
                    <label class="label mr-2">Zip Code</label>
                    <input 
                        type="zipCode"
                        class="input" 
                        name="zipCode"
                        v-model="companyDetails.zipCode">                    
                </div>

                <div class="field">
                    <label class="label mr-2">Phone Number</label>
                    <input 
                        type="phoneNumber"
                        class="input" 
                        name="phoneNumber"
                        v-model="companyDetails.phoneNumber">                    
                </div>                
            
            <!-- submit button -->
        <div class="field has-text-right">
            
            <a v-on:click="goToMainPage()" class="btn btn-primary mr-3"><span style="color:white">Go Back</span></a>            
            <button type="submit" class="button is-danger">Submit</button>

        </div>
                
            </div>
        </form>
    </div>


</div>

</template>

<script>
// @ is an alias to /src
import axios from 'axios'
import moment from 'moment'
// change to commit XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX


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
        
        // axios({
        //     method: "GET",
        //     "url": "https://localhost:44389/api/invoice/getinvoices?companyid="+this.$route.params.id
        // }).then(response => {
        //     this.companyInvoices = response.data;
        // }, error => {
        //     console.error(error);
        // }); 
    },
    data() { 
        return {
            companyDetails: {},   
            //companyInvoices: {},                             
        }
    },
    methods: {
        goToMainPage: function() {
            this.$router.push("/companies");
        },
        processForm: function() {
            const defaultGuid = "00000000-0000-0000-0000-000000000000";
            const methodName = this.companyDetails.id === defaultGuid ? "POST" : "PUT";
            const hostUrl = 
                this.companyDetails.id === defaultGuid 
                    ? "https://localhost:44389/api/company/createcompany" 
                    : "https://localhost:44389/api/company/updatecompany";
            console.log(this.companyDetails);
            axios({
                method: methodName,
                "url" : hostUrl,
                data : this.companyDetails,
            }).then(response => {
                this.companyDetails = response.data;
            }).catch(error =>{
                console.log(error);
            });
        },
        moment
    }
}



</script>
