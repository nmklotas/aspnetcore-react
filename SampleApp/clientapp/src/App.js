import React, { Component } from 'react';
import AppStyle from './AppStyle.js';
import PhonesForm from './PhonesForm/PhonesForm.js';

class App extends Component {
  render() {
    return (
      <AppStyle>
        <div className="App">
          <header className="App-Header">Sample app</header>
          <PhonesForm/>
        </div>
      </AppStyle>
    )
  }
}

export default App