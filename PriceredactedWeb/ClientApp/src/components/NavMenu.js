import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import { SidebarData } from './SidebarData'

export class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor (props) {
    super(props);

    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true
    };
  }

  toggleNavbar () {
    this.setState({
      collapsed: !this.state.collapsed
    });
  }

    render() {
        return (
            <div>
                <nav className="navbar">
                    <ul className="navbar-nav">
                        {SidebarData.map((item, index) => {
                            return (
                                <li key={index} className={item.className}>
                                    <a href={item.ref} className="nav-link">
                                        <svg
                                            aria-hidden={item.aria_hidden}
                                            focusable={item.focusable}
                                            data-prefix={item.data_prefix}
                                            data-icon={item.data_icon}
                                            className={item.svgName}
                                            role={item.role}
                                            xmlns={item.xmlns}
                                            viewBox={item.viewBox}
                                        >
                                        <g className={item.g_name}>
                                            <path fill={item.fill} d={item.d1} className="fa-secondary" ></path>
                                            <path fill={item.fill} d={item.d2} className="fa-primary"></path>
                                        </g>
                                        </svg>
                                        <span className={item.textName}>{item.title}</span>
                                    </a>
                                </li>
                                )
                        })}
                    </ul>
                </nav>
            </div>
);
  }
}
