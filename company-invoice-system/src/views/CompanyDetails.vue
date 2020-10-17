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
            Company Details
        </div>
        <div class="card-body">
            <h2 class="card-title">{{companyDetails.name}}</h2>
            <!-- <p class="card-text">Company Name : {{companyDetails.name}}</p> -->
            <p class="card-text">EIN : {{companyDetails.ein}}</p>
            <p class="card-text">Is Domestic : {{  getLookupValue('YesNo', (companyDetails.isDomestic ? 1 : 0)) }}</p>
            <p class="card-text">{{companyDetails.addressStreet !== null ? companyDetails.addressStreet  + ' ' + companyDetails.addressUnitNumber : null}}</p>
            <p class="card-text">{{companyDetails.city != null ? companyDetails.city + ', ' + companyDetails.state + ' ' + companyDetails.zipCode : null }}</p>
            <p class="card-text">{{companyDetails.phoneNumber}}</p>


            <div class="col-4 centeralign">
                <table class="table table-bordered table-responsive-sm">
                <thead>
                    <tr>
                    <th scope="col" class="col-xs-1">#</th>
                    <th scope="col" class="col-xs-2">Invoice Date</th>
                    <th scope="col" class="col-xs-2">Invoice Type</th>
                    <th scope="col" class="col-xs-2">Invoice Total</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="invoice in companyInvoices" :key="invoice.id">
                    <th scope="row" class="col-xs-1">
                        <a class="btn btn-outline-secondary" v-on:click="goToDetailsPage(invoice.id)">Details</a>
                    </th>
                    <td class="col-xs-2">{{ moment(String(invoice.invoiceDate)).format('MM/DD/YYYY') }}</td>
                    <td class="col-xs-2">{{ getLookupValue('InvoiceType', invoice.invoiceType) }} </td>
                    <td class="col-xs-2">{{invoice.totalValue}}</td>
                    </tr>            
                </tbody>
                </table>
            </div>

            <a v-on:click="goToMainPage()" class="btn btn-primary"><span style="color:white">Go Back</span></a>



        </div>
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
            method: "POST",
            "url": "https://localhost:44389/api/lookupvalue/GetLookupValues",
            data : {
                "EnumTypes": ["InvoiceType", "YesNo"]
            }
        }).then(response => {
            this.lookupValues = response.data.lookupValues;
        }, error => {
            console.error(error);
        }); 

        axios({
            method: "GET",
            "url": "https://localhost:44389/api/company/getcompany?id="+this.$route.params.id
        }).then(response => {
            console.log(response.data);
            this.companyDetails = response.data;
            console.log(this.companyDetails);
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
            lookupValues : {},
            companyDetails: {},   
            companyInvoices: {},                             
        }
    },
    methods: {
        goToMainPage : function() {
            this.$router.push("/companies");
        },        
        // getInvoiceTypeValue : function(key) {            
        //     return this.lookupValues['InvoiceType'][key];
        // },
        getLookupValue : function(t, k) {
            //console.log(this.lookupValues[t][k]);
            return this.lookupValues[t][k];
        },
        moment
    }
}


</script>
