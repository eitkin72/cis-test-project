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
    <div class="card centeralign">
        <!-- <p>Companies</p> -->
        <div class="card-header">
            Companies
        </div>
        <div class="card-body col-md-6 centeralign">
            <!-- <p>Clicking on a Card Displays the name below. This is to demonstrate passing data from parent to child component</p>
            <p>"Click for more details" Redirects to a new page which displays the company information</p> -->
                
            <table class="table table-bordered table-responsive-sm">
            <thead>
                <tr>
                <th scope="col">
                    <a class="btn btn-outline-secondary" v-on:click="goToAddEditCompanyPage(defaultGuid)">Create Company</a>
                </th>
                <th scope="col" class="col-xs-1">Company Name</th>
                <th scope="col" class="col-xs-1">EIN</th>
                <th scope="col" class="col-xs-1">Domestic</th>
                <!-- <th scope="col" class="col-xs-1">Street Address</th>
                <th scope="col" class="col-xs-1">City</th>
                <th scope="col" class="col-xs-1">State</th>
                <th scope="col" class="col-xs-1">Zip Code</th>
                <th scope="col" class="col-xs-4">Phone Number</th> -->
                </tr>
            </thead>
            <tbody>
                <tr v-for="company in companylist" :key="company.id" v-on:click="setSelectedCompany(company)" >
                <th class="col-xs-1" scope="row">
                    <a class="btn btn-outline-secondary mr-1" v-on:click="goToDetailsPage(company.id)">Details</a>
                    <a class="btn btn-outline-secondary" v-on:click="goToAddEditCompanyPage(company.id)">Edit</a>
                </th>                
                <td class="col-xm-1">{{company.name}}</td>
                <td class="col-xm-1">{{company.ein}}</td>
                <td class="col-xm-1">{{company.isdomestic == null || company.isdomestic === 0 ? "No" : "Yes"}}</td>
                <!-- <td class="col-xm-1">{{company.addressStreet}}, {{company.addressUnitNumber}}</td>
                <td class="col-xm-1">{{company.city}}</td>
                <td class="col-xm-1">{{company.state}}</td>
                <td class="col-xm-1">{{company.zipCode}}</td>
                <td class="col-xm-4">{{company.phoneNumber}}</td> -->
                </tr>                        
            </tbody>
            </table>                     

            <Display v-if="selectedCompany!=''" :selectedCompany="selectedCompany" />
        </div>   
    </div>
</div>

</template>

<script>

// @ is an alias to /src
import Display from '@/components/Display.vue'
import axios from 'axios'

export default {
    name: 'companies',
    mounted() {
        axios(
            {
            method: "GET",                        
            //"url": "assets/samplejson/customerlist.json"
            "url": "https://localhost:44389/api/company/getcompanies"
        }).then(response => {
            this.companylist = response.data;
        }, error => {
            // eslint-disable-next-line
            console.error(error);
        });
    }, 
    data() {
        return {
            companylist: [],
            selectedCompany: "",
            defaultGuid : "00000000-0000-0000-0000-000000000000",            
        }
    },
    components: {
        Display
    },
    methods: {        
        setSelectedCompany: function(c) {  
            // var details1 = [                   
            //         { name : c.name }, 
            //         { ein : 'EIN: ' + c.ein } ,
            //         { addressLine1 : c.addressStreet !== null ? c.addressStreet  + ' ' + c.addressUnitNumber : null },
            //         { addressLine2 : c.city != null ? c.city + ', ' + c.state + ' ' + c.zipCode : null },
            //         { phoneNumber : c.phoneNumber }
            //    ];
            var details = [                   
                    c.name, 
                    'EIN: ' + c.ein ,
                    c.addressStreet !== null ? c.addressStreet  + ' ' + c.addressUnitNumber : null ,
                    c.city != null ? c.city + ', ' + c.state + ' ' + c.zipCode : null ,
                    c.phoneNumber 
                ];
            
                    
            // var filtered = details.data.items.filter(function (el) {
            //     return el.value != null;
            // }); 
            // details.data.items = filtered;               
            this.selectedCompany = details;
        },
        goToDetailsPage: function(id) {
            this.$router.push("/companydetails/"+id);
        },
        goToAddEditCompanyPage: function(id) {
            this.$router.push("/companyaddedit/"+id);
        }

    }
}

</script>
