import React, { Component } from 'react';
import './Buttons.css'
import { TestProductsData } from './TestProductsData'

export class Scan extends Component {
    static displayName = Scan.name;

    constructor(props) {
        super(props);
        this.state = { skaicius: 9990 };
        this.incrementCounter = this.incrementCounter.bind(this);
    }

    incrementCounter() {
        this.setState({skaicius: this.state.skaicius + 1});
    }

    render() {
        return (
            <main>
                <div>
                        <span style={{'fontSize': '1.5rem'}}>SCAN RECEIPT</span>
                        <p>Current count: <strong>{this.state.skaicius}</strong></p>
                        <button className="basicButton" onClick={this.incrementCounter}>Increment</button>
                        <p style={{ 'padding': '2rem'}}></p>
                        <table style={{'background-color': 'var(--bg-primary)'}} className="table table-sm table-hover table-dark">
                            <thead>
                                <tr>
                                <th scope="col">Shop</th>
                                <th scope="col">Name</th>
                                <th scope="col">Price</th>
                                </tr>
                            </thead>
                            <tbody>
                                {TestProductsData.map((item, index) => {
                                    return(
                                        <tr key={index}>
                                        {/* <th scope="row">{item.index}</th> */}
                                        <td>{item.shop}</td>
                                        <td>{item.name}</td>
                                        <td>{item.price}</td>
                                        </tr>
                                    )
                                })}
                            </tbody>
                        </table>
                </div>
            </main>
        )
    }
}
