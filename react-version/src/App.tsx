import React from 'react';
import './App.css';

type AppState = {
  counter: number;
}

type AppProps = {
  initialCounterValue: number
}

class App extends React.Component<AppProps, AppState> {
  constructor(props: AppProps) {
    super(props);
    this.state = {
      counter: props.initialCounterValue
    }

    this.increment = this.increment.bind(this);

  }

  increment() {
    this.setState({ counter: this.state.counter + 1 });
  }

  render() {
    return (
      <div className="App">
        <p className="counter">{this.state.counter}</p>
        <button onClick={this.increment} className="incrementButton">Increment</button>
      </div>
    );
  }
}

export default App;
