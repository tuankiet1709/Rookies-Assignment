import { getCategoriesOptionRequest } from "../Category/services/request"
import { useEffect, useState } from "react";


export default function Home() {
  const [output, input] = useState([]); 
  const [categories, setCategories] = useState([]);

  useEffect(() => {
    async function fetchDataAsync() {
      let result = await getCategoriesOptionRequest();
      setCategories(result.data)
      input(Object.values(result.data));
    }

    fetchDataAsync();
  }, []);
  console.log(output);
  console.log(categories);

  return (
    <div>
      <h2>Home</h2>
    </div>
  );
}