import React, { Component } from 'react';
import Grid from '@material-ui/core/Grid';
import './Buttons.css'
import './DropDowns.css'

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
              </div>
              <div>
                  <Grid container direction="row" spacing={4}>
                      <Grid item>
                          <button className="basicButton" /*onClick={() => setUpload(true)}*/>Filter</button>
                      </Grid>
                      <Grid item>
                          <label for="Shop">Shop:</label>
                          <select name="Shop" className="basicDropDown" id="Shop">
                              <option value="Iki">Iki</option>
                              <option value="Lidl">Lidl</option>
                              <option value="Maxima">Maxima</option>
                              <option value="Norfa">Norfa</option>
                              <option value="Rimi">Rimi</option>
                          </select>
                      </Grid>
                      <Grid item>
                          <label for="ItemGroup">Item group:</label>
                          <select name="ItemGroup" className="basicDropDown" id="ItemGroup">
                              <option value="Fruit">Fruit</option>
                              <option value="Vegetable">Vegetable</option>
                              <option value="Dairy">Dairy</option>
                              <option value="Meat">Meat</option>
                              <option value="Baked goods">Baked goods</option>
                              <option value="Electronics">Electronics</option>
                              <option value="Sweets">Sweets</option>
                              <option value="Alc. Drinks">Alc. Drinks</option>
                              <option value="Soda">Soda</option>
                              <option value="Juice">Juice</option>
                              <option value="Snacks">Snacks</option>
                              <option value="Pasta">Pasta</option>
                              <option value="Icecream">Icecream</option>
                              <option value="Frozen goods">Frozen goods</option>
                              <option value="Bathroom goods">Bathroom goods</option>
                              <option value="Cleaning">Cleaning</option>
                              <option value="Pets">Pets</option>
                          </select>
                      </Grid>
                      <Grid item>
                          <label for="Product">Product:</label>
                          <input type="text" id="Product" name="Product"></input>
                      </Grid>
                      <Grid item>
                          <label for="PriceUnit">Price unit:</label>
                          <select name="PriceUnit" className="basicDropDown" id="PriceUnit">
                              <option value="Eur/Unit">Eur/Unit</option>
                              <option value="Eur/kg">Eur/kg</option>
                          </select>
                      </Grid>
                      <Grid item>
                          <label for="Price">Price:</label>
                          <input type="text" id="Price" name="Price"></input>
                      </Grid>
                  </Grid>
              </div>
              <div>
                {contents}
             </div>
        </main>
    );
  }

  async populateWeatherData() {
      const response = await fetch('https://localhost:44310/api/Products');
    const data = await response.json();
    this.setState({ forecasts: data, loading: false });
  }
}
