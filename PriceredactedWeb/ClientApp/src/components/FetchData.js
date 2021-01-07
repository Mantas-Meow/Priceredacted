import React, { Component } from 'react';
import Grid from '@material-ui/core/Grid';
import './Buttons.css'
import './DropDowns.css'

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
    this.state = { forecasts: [], loading: true, shop: "", itemGroup: "", productName: "", priceUnit: "", price: ""};
  }

  componentDidMount() {
    this.populateWeatherData();
  }
  async filterClick() {
    const data = {Shop: this.state.shop,
                   ItemGroup: this.state.itemGroup,
                   Name: this.state.productName,
                   PriceUnit: this.state.priceUnit,
                   Price: this.state.price}
        const requestOptions = {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'},
            body: JSON.stringify(data)
        };
        const response = await fetch('https://localhost:5001/api/Search', requestOptions);
        const result = await response.json();
        this.setState({forecasts: result});
        console.log(result);
  }
  static renderForecastsTable(forecasts) {
    
    return (
      <table style={{'backgroundColor': 'var(--table-color)'}} className="table table-hover table-dark ">
        <caption>Products in database</caption>
        <thead style={{'backgroundColor': 'var(--bg-primary)'}}>
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
                          <button className="basicButton" onClick={() => this.filterClick()}/*onClick={() => setUpload(true)}*/>Filter</button>
                      </Grid>
                      <Grid item>
                          <label htmlFor="Shop">Shop:</label>
                          <select name="Shop" className="basicDropDown" id="Shop" onChange={(e) => this.setState({shop: e.target.value})}>
                              <option value=""></option>
                              <option value="Iki">Iki</option>
                              <option value="Lidl">Lidl</option>
                              <option value="Maxima">Maxima</option>
                              <option value="Norfa">Norfa</option>
                              <option value="Rimi">Rimi</option>
                          </select>
                      </Grid>
                      <Grid item>
                          <label htmlFor="ItemGroup">Item group:</label>
                          <select name="ItemGroup" className="basicDropDown" id="ItemGroup" onChange={(e) => this.setState({itemGroup: e.target.value})}>
                              <option value=""></option>
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
                          <label htmlFor="Product">Product:</label>
                          <input type="text" id="Product" name="Product" onChange={(e) => this.setState({productName: e.target.value})}></input>
                      </Grid>
                      <Grid item>
                          <label htmlFor="PriceUnit">Price unit:</label>
                          <select name="PriceUnit" className="basicDropDown" id="PriceUnit" onChange={(e) => this.setState({priceUnit: e.target.value})}>
                              <option value=""></option>
                              <option value="Eur/Unit">Eur/Unit</option>
                              <option value="Eur/kg">Eur/kg</option>
                          </select>
                      </Grid>
                      <Grid item>
                          <label htmlFor="Price">Price:</label>
                          <input type="float" id="Price" name="Price" onChange={(e) => this.setState({price: e.target.value})}></input>
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
      const response = await fetch('https://localhost:5001/api/Products');
    const data = await response.json();
    this.setState({ forecasts: data, loading: false });
  }
}
