<template>
  <div id="app">
    <Navbar/>
    <Header/>
    <Content/>
    
  </div>
</template>

<script>
import Navbar from './components/layout/TheNavbar.vue'
import Header from './components/layout/TheHeader.vue'
import Content from './components/layout/TheContent.vue'


export default {
  name: 'App',
  components: {
    Navbar,
    Header,
    Content
  }
}
</script>

<style>
@import "./styles/index.css";
</style>
