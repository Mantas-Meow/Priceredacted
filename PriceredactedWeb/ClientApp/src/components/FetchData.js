import React, { Component } from 'react';

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
    this.state = { forecasts: [], loading: true };
  }

  componentDidMount() {
    this.populateWeatherData();
  }

  static renderForecastsTable(forecasts) {
    return (
      <table style={{'background-color': 'var(--table-color)'}} className="table table-hover table-dark ">
        <caption>Products in database</caption>
        <thead style={{'background-color': 'var(--bg-primary)'}}>
          <tr>
            <th scope="col">Shop</th>
            <th scope="col">Item group</th>
            <th scope="col">Name</th>
            <th scope="col">Price Unit</th>
            <th scope="col">Price</th>
          </tr>
        </thead>
        <tbody>
          {forecasts.map((Product, index) => {
              return(
              <tr key={index}>
              <td>{Product.shop}</td>
              <td>{Product.itemGroup}</td>
              <td>{Product.name}</td>
              <td>{Product.priceUnit}</td>
              <td>{Product.price}</td>
              </tr>
              )
            })}
        </tbody>
      </table>
    );
    }

    render() {
        let contents = this.state.loading ? <p><em>Loading...</em></p> : FetchData.renderForecastsTable(this.state.forecasts);

      return (
        <main>
             <div>
                <span className="headline-text">Search</span>
                <p>Search for a product</p>
                {contents}
            </div>
        </main>
    );
  }

  async populateWeatherData() {
      const response = await fetch('https://localhost:5001/api/Products');
    const data = await response.json();
    this.setState({ forecasts: data, loading: false });
  }
}
