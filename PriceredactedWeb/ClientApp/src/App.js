import React, { Component } from 'react';
import { Home } from './components/Home';
import { default as Scan } from './components/Scan';
import { FetchData } from './components/FetchData';
import  Counter  from './components/Counter.js';
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom'
import { NavMenu as Navbar } from './components/NavMenu.js'
import  Login  from './components/Login.js'
import   Registration from './components/Registration.js'
import './custom.css'
import './components/styles.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
        <Router>
            <Navbar />
            <Switch>
                <Route exact path='/' component={Home} />
                <Route path='/login' component={Login} />
                <Route path='/register' component={Registration} />
                <Route path='/counter' component={Counter} />
                <Route path='/fetch-data' component={FetchData} />
                <Route path='/scan' component={Scan} />
            </Switch>
        </Router>
    );
  }
}
