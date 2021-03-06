﻿import React from "react";
import { elastic as Menu } from "react-burger-menu";
import './SideBar.css';


export class SideBar extends React.Component {
    constructor(props) {
        super(props);

    }


    render() {
        return (
            <Menu>
                <a className="menu-item" onClick={() => this.props.moveToComponent("home")}>Home</a>

                <a className="dropdown">
                    <a className="dropbtn">Grids
                    <i className="fa fa-caret-down"></i>
                    </a>
                    <div className="dropdown-content">
                        <a className="menu-item" onClick={() => this.props.moveToComponent("sprints")}>Sprints</a>
                        <a className="menu-item" onClick={() => this.props.moveToComponent("feature")}>Features</a>
                        <a className="menu-item" onClick={() => this.props.moveToComponent("stories")}>Stories</a>
                        <a className="menu-item" onClick={() => this.props.moveToComponent("tasks")}>Tasks</a>
                        <a className="menu-item" onClick={() => this.props.moveToComponent("defects")}>Defects</a> 
                    </div>
                </a> 

                <a className="menu-item" onClick={() => this.props.moveToComponent("kanbanBoard")}>Kanban</a>
                
            </Menu>
        );
    }
};


