import React, { Component } from 'react';
import Logo from '../Resources/PriceRedacted.png';
import './Style.css';

export class Home extends Component {
    static displayName = Home.name;
    componentDidMount() {
            this.makeAPICall();
    }
    async makeAPICall() {
        const response = await fetch('api/users');
        const data = await response.json();
        console.log(data);
    }


    render () {
        return (
            <main>
                <div>
                    <span className="headline-text">Home</span>
                    
                </div>
            </main>
        );
  }
}
