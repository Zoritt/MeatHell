<template>
  <div>
    <h4 class="bg-primary text-white text-center p-2">
      Lista zadań użytkownika Adam
    </h4>
<table class="table table-striped table-bordered table-sm">
  <thead>
    <tr><th>Zadanie</th><th>Czy wykonano?</th></tr>
  </thead>
  <tbody>    
    
    <tr v-for="t in tasks" v-bind:key="t.action">
      <td>{{t.action}}</td>
      <td>{{t.done}}</td>
    </tr>
  </tbody>
</table>
<div class="form-group m-2">
  <label>Nowy element:</label>
  <input v-model="newItemText" class="form-control"/>
</div>
<div class="text-center">
  <button class="btn btn-primary" v-on:click="addNewTodo">Dodaj
  </button>
</div>
  </div>
</template>

<script>
export default {
  data:function(){
    return {
      tasks:[{action:"Kup kwiaty", done:false},
    {action:"Znajdź buty", done:false},
    {action:"Odbierz bilety", done:true},
    {action:"Zadzwoń do Janks", done:false}],
    newItemText:""
    }
  },
  methods:{
    addNewTodo(){
      this.tasks.push({
        action:this.newItemText,
        done:false
      });
      this.newItemText="";
    }
  }
}
</script>

