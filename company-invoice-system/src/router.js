import Vue from 'vue'
import Router from 'vue-router'
import Companies from './views/Companies.vue'
import CompanyDetails from './views/CompanyDetails.vue'
import CompanyAddEdit from './views/CompanyAddEdit.vue'

Vue.use(Router)

const router =  new Router({
  routes: [
    {
      path: '/',
      redirect: '/companies'
    },          
    {
      path: '/companies', 
      name: 'companies',
      component: Companies
    },
    {
      path: '/companydetails/:id',
      name: 'companydetails',
      component: CompanyDetails
    },
    {
      path: '/companyaddedit/:id',
      name: 'companyaddedit',
      component: CompanyAddEdit
    }
  ]
})
export default router
