setInterval(setClock, 1000)

const hourHand = document.querySelector('[data-hour-hand]')
const minuteHand = document.querySelector('[data-minute-hand]')
const secondHand = document.querySelector('[data-second-hand]')

function setClock() {
    const currentDate = new Date()
    const secondsRatio = currentDate.getSeconds() / 60
    const minutesRatio = (secondsRatio + currentDate.getMinutes()) / 60
    const hoursRatio = (minutesRatio + currentDate.getHours()) / 12
    setRotation(secondHand, secondsRatio)
    setRotation(minuteHand, minutesRatio)
    setRotation(hourHand, hoursRatio)
}

function setRotation(element, rotationRatio) {
  element.style.setProperty('--rotation', rotationRatio * 360)
}

setClock()


class DigitalClock {
    constructor(element) {
    this.element = element;
    }

    start() {
    this.update();

    setInterval(() => {
        this.update();
    }, 500);
    }

    update() {
    const parts = this.getTimeParts();
    const minuteFormatted = parts.minute.toString().padStart(2, "0");
    const timeFormatted = `${parts.hour}:${minuteFormatted}`;
    const amPm = parts.isAm ? "AM" : "PM";

    this.element.querySelector(".time").textContent = timeFormatted;
    this.element.querySelector(".ampm").textContent = amPm;
    }

    getTimeParts() {
    const now = new Date();

    return {
        hour: now.getHours() % 12 || 12,
        minute: now.getMinutes(),
        isAm: now.getHours() < 12
    };
    }
}

const clockElement = document.querySelector(".clock_digital");
const clockObject = new DigitalClock(clockElement);

clockObject.start();