<template>
  <h1>Text Search</h1>
  <p>This counts the number of occurrences of text found in the sentence.</p>
  <form @submit.prevent="getMatchCount">
    <div>
      <label for="sentence">Sentence</label>
      <span class="error-msg error-msg-sentence" v-if="errorMessages.sentence">{{ errorMessages.sentence }}</span>
      <textarea :class="[`${errorMessages.sentence ? 'error-border' : undefined}`]" id="sentence" cols="30" rows="10" v-model="textSearchObject.sentence"></textarea>
    </div>

    <div>
      <label for="text">Text to search</label>
      <input type="text" id="text" v-model="textSearchObject.text" :class="[`${errorMessages.text ? 'error-border' : undefined}`]"/>
      <span class="error-msg error-msg-text" v-if="errorMessages.text">{{ errorMessages.text }}</span>
    </div>

    <div>
      <input type="checkbox" id="isFullWordSearch" v-model="textSearchObject.isFullWordSearch" />
      <label for="isFullWordSearch">Full Word Search</label>
    </div>

    <div>
      <input type="checkbox" id="isCaseSensitive" v-model="textSearchObject.isCaseSensitive" />
      <label for="isCaseSensitive">Case Sensitive Search</label>
    </div>
    <button>Search</button>

    <p>Number of occurrences {{ textOccurrence }}</p>
  </form>
</template>

<script>
import { textSearchApi } from '../../utils/api';

  export default {
    data() {
      return {
        textSearchObject: {
          sentence: "",
          text: "",
          isFullWordSearch: false,
          isCaseSensitive: false, 
        },
        errorMessages: {
          sentence: "",
          text: ""
        },
        textOccurrence: ""
      }
    },
    methods: {
      async getMatchCount() {
          const data = await textSearchApi(this.textSearchObject);
        
          if (data.text || data.sentence) {
            this.errorMessages.text = data.text && data.text[0];
            this.errorMessages.sentence = data.sentence && data.sentence[0];
          } else {
            this.resetForm();
            this.textOccurrence = data;
          }

      },
      resetForm() {
        this.textSearchObject.sentence = "";
        this.textSearchObject.text = "";
        this.textSearchObject.isFullWordSearch = false;
        this.textSearchObject.isCaseSensitive = false;
        this.errorMessages.sentence = "";
        this.errorMessages.text = "";
      }
    }
  }

</script>

<style scoped>
</style>
