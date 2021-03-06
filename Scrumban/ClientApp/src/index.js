import 'bootstrap/dist/css/bootstrap.css';

import 'bootstrap/dist/css/bootstrap-grid.min.css';

import "react-datepicker/dist/react-datepicker.css";

import './index.css';
import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter } from 'react-router-dom';
import App from './App';
import registerServiceWorker from './registerServiceWorker';
//import '../node_modules/bootstrap/dist/css/bootstrap.css';

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const rootElement = document.getElementById('root');


ReactDOM.render(
  <BrowserRouter basename={baseUrl}>
    <App />
  </BrowserRouter>,
  rootElement);

registerServiceWorker();