const outputSection = document.querySelector("#output-section");
const getAllDriversBtn = document.querySelector("#get-all-drivers-btn");

const getAllDrivers = async () => {
  try {
    const result = await axios.get("http://localhost:5282/api/drivers");
    showDrivers(result.data);
    console.log(result);
  } catch (err) {
    console.log(err);
  }
};

/*  Output on web page  */
const showDrivers = (driverArray) => {
  driverArray.forEach((driver) => {
    showDriver(driver);
  });
};

const showDriver = (driver) => {
  let htmlTxt = `
        <div class="col col-sm-12 col-md-6 col-lg-4">
          <article class="border border-secondary rounded shadow mb-5 bg-white rounded">
            <div class="p-2 ">
              <div class="text-center">
                <h3 class="">${driver.name} (${driver.id})</h3>
                <img class="driver-img" src="http://localhost:5282/images/${driver.image}">
              </div>
              <p>Age: ${driver.age}</p>
              <p>Nationality: ${driver.nationality}</p>
            </div>
          </article>
        </div>
    `;
  outputSection.innerHTML += htmlTxt;
};

/*  Event listeners  */
getAllDriversBtn.addEventListener("click", () => {
  getAllDrivers();
});
