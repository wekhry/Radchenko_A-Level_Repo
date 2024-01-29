import axios from 'axios';

export const getAll = async () => {
  return axios.get('https://reqres.in/api/unknown');
};
