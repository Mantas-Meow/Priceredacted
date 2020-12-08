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
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Shop</th>
            <th>Item group</th>
            <th>Name</th>
            <th>Price Unit</th>
            <th>Price</th>
          </tr>
        </thead>
        <tbody>
          {//forecasts.map(forecast =>
            forecasts.map(Product =>
            <tr key={Product.Shop}>
              <td>{Product.ItemGroup}</td>
              <td>{Product.Name}</td>
              <td>{Product.PriceUnit}</td>
              <td>{Product.Price}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchData.renderForecastsTable(this.state.forecasts);

    return (
      <div>
        <h1 id="tabelLabel" >Weather forecast</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateWeatherData() {
      const response = await fetch('https://localhost:44310/api/Products');
    const data = await response.json();
    this.setState({ forecasts: data, loading: false });
  }
}
